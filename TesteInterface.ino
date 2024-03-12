//Testando - Interface Arduino (Acender led do próprio arduino + Mexer no Servo + Ligar Led)
#include <Servo.h> //Add the servo library

String data; //To hold the information that gets transmitted the string that transmitted from the PC
char d1; //Hold the first character of that string

//Variáveis
String x; //Hold servo angle
int servoval; //Store the number to send to the servo
Servo s1; //Instance of servo(object)

int ledval;
int luminosidade;
float temperatura = 0;

void setup() {
  Serial.begin(9600); //Inicialização da Porta Serial
  pinMode(A0, INPUT); //Pino do Sensor LDR
  pinMode(A1, INPUT); //Pino do Sensor LM35
  pinMode(13, OUTPUT); //Pino 13 do led do próprio arduino
  pinMode(3, OUTPUT); //Pino do Led
  pinMode(4, OUTPUT); //Pino do Led (interage com sensor LDR)
  pinMode(5, OUTPUT); //Pino do Led (interage com sensor LM35)
  s1.attach(9);     //make output 9 the servo channel
}

void loop() {
  //Code we need to Decode the String and turn the led on and off
  if(Serial.available()){
    data = Serial.readString();
    d1 = data.charAt(0);
    switch(d1){             //select action based upon first character
      //Função: Ligar Led do arduino
      case 'A':             //first character is an A = turn on pin 13 led
      digitalWrite(13, HIGH);
      break;

      //Função: Desligar Led do arduino
      case 'a':             //first character is an a = turn off
      digitalWrite(13, LOW);
      break;

      //Função: Settar ângulo para o servo: a partir de caixa de texto
      case 'S':            //first character is an S = set servo angle
      x = data.substring(1);
      servoval = x.toInt(); //Convert the string x to an integer 
      s1.write(servoval);
      delay(100);     //wait for servo to finish - performance
      break;

      //Função: Settar ângulo para o servo: a partir de uma trackbar
      case 'Z':
      x = data.substring(1);
      servoval = x.toInt(); //Convert the string x to an integer 
      s1.write(servoval);
      delay(100);     //wait for servo to finish - performance
      break; 

      //Função: Ligar led
      case 'B':
      digitalWrite(3, HIGH);
      break;
      
      //Função: Desligar led
      case 'b':
      digitalWrite(3, LOW);
      break;

      //Função: Ligar sensor LDR
      case 'D':
      luminosidade = analogRead(A0);
      if (luminosidade < 100) {
        digitalWrite(4, HIGH);
      } else { //luminosidade >= 100
        digitalWrite(4, LOW);
      }
      break;
      
      //Função: Ligar sensor LM35 
      case 'E':
      temperatura = (analogRead(A1) * 0.0048828125 * 100); //VARIÁVEL RECEBE A TEMPERATURA MEDIDA
      if (temperatura > 30){
        digitalWrite(5, HIGH);
      } else { //temperatura <= 30 
        digitalWrite(5, LOW);
      }
      break;

      //Função: Settar intensidade de um led 
      case 'R':              //set the red LED intensity
      x  = data.substring(1);
      ledval = x.toInt();
      analogWrite(3, ledval);      
      break;
    }
    /* -- if else : de ligar e apagar a luz do arduino
    if(d1 == 'A'){
      digitalWrite(13, HIGH);
    } 
    else if(d1 == 'a'){
      digitalWrite(13, LOW);
    }
    */
  }
}
