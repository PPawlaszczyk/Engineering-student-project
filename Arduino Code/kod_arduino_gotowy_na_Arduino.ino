#include <Wire.h>
#include <MPU6050.h>
MPU6050 mpu;
float liczba2_os_z;
float liczb2_os_y;
float liczba2_os_x;
void setup()
{
  Serial.begin(9600);
  pinMode(8, OUTPUT);
  while (!mpu.begin(MPU6050_SCALE_2000DPS, MPU6050_RANGE_2G)) // skala odczytu z czujnikow
  {
    Serial.println("Could not find a valid MPU6050 sensor, check wiring!"); // wiadomosc gdy nie wykryto urzadzenia
    delay(500);
  }
}
void loop()
{
  delay(1000);

  int wysylane = 1;
  if (wysylane == 1);
  {
    Vector normAccel = mpu.readNormalizeAccel();  //tworzenie dynamiczanej tablicy z wynikow pomiarowych
    float liczba1_os_z = normAccel.ZAxis;
    float wynik_z;
    wynik_z = liczba1_os_z - liczba2_os_z;
    wynik_z = abs(wynik_z);
    float liczb1_os_y = normAccel.YAxis;
    float wynik_y;
    wynik_y = liczb1_os_y - liczb2_os_y;
    wynik_y = abs(wynik_y);
    float liczba1_os_x = normAccel.XAxis;
    float wynik_x;
    wynik_x = liczba1_os_x - liczba2_os_x;
    wynik_x = abs(wynik_z);
    if (wynik_z > 1 || wynik_x > 1 || wynik_y > 1)
    {
      Serial.println("1");
    }
    else
    {
      Serial.println("0");
    }
    liczba2_os_z = normAccel.ZAxis;
    liczba2_os_x = normAccel.XAxis;
    liczb2_os_y = normAccel.YAxis;
    delay(100);
  }
  if (Serial.available()) //aktywowanie portu szeregowego
  {
    int data = Serial.read(); //zdefiniowanie zmiennej, która będzie odbierana z portu szeregowego
    if (data == 'A')
    {
      digitalWrite(8, HIGH); //Włączenie diody
    }
    if (data == 'C')
    {
      digitalWrite(8, LOW); //Wyłączenie diody
    }
  }
}
