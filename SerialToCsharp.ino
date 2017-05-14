int potentiometerValue = 0;
int toSend = 0;
int potentiometer = A0;

void setup(){  
  pinMode(potentiometer, INPUT);
  Serial.begin(9600);
}

void loop(){
  potentiometerValue = analogRead(potentiometer);
  toSend = map(potentiometerValue, 0, 1023, 0, 255);  
  Serial.println("Ich bin ein Text :)");
  Serial.println(toSend);
  
  delay(300);
}
