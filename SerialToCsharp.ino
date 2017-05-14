//Autor: Stefan Schindlegger
//This program reads an analog value from a potentiometer and sends it over the serial port to the PC.
//A C# program reads the incoming values and prints them in the console. 

int potentiometerValue = 0;  //variable to store the value of the potentiometer
int toSend = 0;              //the value which is sent to the C# program
int potentiometer = A0;      //name of the analog pin to which the potentiometer is connected

void setup(){  
  pinMode(potentiometer, INPUT);  //define the analog pin as input
  Serial.begin(9600);             //define the serial connection with a boud rate of 9600
}

//for each iteration of the loop:
void loop(){
  potentiometerValue = analogRead(potentiometer);  //the ADC of the Arduino maps the input voltage
                                                   //of the analog pin (A0) to a value between 0-1023 (10 bit ADC -> 2^10 = 1024)
                                                   
  toSend = map(potentiometerValue, 0, 1023, 0, 255);  //now the potentioometerValue is maped to a value between 0 and 255 
  Serial.println(toSend); // then the value is sent to the C# program
  Serial.println("I am a text :)"); //this is to show that you can also send text
   
  delay(300); //a short delay
}
