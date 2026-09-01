#include <Arduino.h>

// micro:bit v2 doesn't have a single "onboard LED" like Uno's pin 13 —
// it has a 5x5 LED matrix wired as rows (source) x columns (sink).
// These are the PlatformIO Arduino-core pin numbers for row 1 / col 1.
#define LED_ROW1 21
#define LED_COL1 4

void setup() {
  pinMode(LED_ROW1, OUTPUT);
  pinMode(LED_COL1, OUTPUT);

  // Columns sink current, so LOW = "on" for that column
  digitalWrite(LED_COL1, LOW);
}

void loop() {
  digitalWrite(LED_ROW1, HIGH);  // top-left LED on
  delay(1000);
  digitalWrite(LED_ROW1, LOW);   // off
  delay(1000);
}