# Loadcell Measurement System with LM358 & STM32

[![Hardware](https://img.shields.io/badge/Hardware-STM32F103C8-blue)](https://www.st.com/en/microcontrollers-microprocessors/stm32f103c8.html)
[![Firmware](https://img.shields.io/badge/Firmware-Keil_MDK-green)](https://www.keil.com/)
[![Software](https://img.shields.io/badge/GUI-C%23_.NET-purple)](https://visualstudio.microsoft.com/)
[![IDE](https://img.shields.io/badge/VS-2022-5C2D91)](https://visualstudio.microsoft.com/)

## Project Overview

This project is a precision weight measurement system. It interfaces a **Loadcell** sensor with an **STM32F103C8** microcontroller using an **LM358** operational amplifier for signal conditioning. The captured data is processed and transmitted to a PC, where a custom **Windows Forms (GUI)** application visualizes the real-time measurement data.

**Key Components:**
1.  [cite_start]**Firmware:** `Loadcell_LM358` - STM32 C code for ADC conversion and UART transmission[cite: 2, 7].
2.  [cite_start]**Software:** `GUI_DLCN` - A C# Windows application for data monitoring.

## System Architecture

### 1. Hardware Layer
* [cite_start]**MCU:** STM32F103C8 (ARM Cortex-M3)[cite: 2, 3].
* **Sensor:** Loadcell (Strain Gauge).
* [cite_start]**Signal Conditioning:** LM358 Operational Amplifier (Non-inverting amplifier configuration inferred from project name)[cite: 7].
* **Communication:** UART (Serial) interface to PC.

### 2. Firmware Layer (STM32)
[cite_start]The firmware is developed using **Keil uVision 5**  [cite_start]and utilizes the **STM32 HAL Library**[cite: 46]. Key peripherals configured include:
* [cite_start]**ADC (Analog-to-Digital Converter):** Reads the amplified analog voltage from the LM358[cite: 56, 57].
* [cite_start]**UART (Universal Asynchronous Receiver-Transmitter):** Transmits weight data to the GUI[cite: 64].
* [cite_start]**GPIO:** Pin configurations for sensor interfacing[cite: 55, 59].
* [cite_start]**RCC:** System clock configuration[cite: 58].

### 3. Software Layer (PC GUI)
[cite_start]The desktop interface is built with **Microsoft Visual Studio 2022 (v17.13)**.
* [cite_start]**Project Name:** `GUI_DLCN`.
* **Functionality:** Receives serial data from the STM32 and displays weight readings to the user.

## Project Structure

```text
├── GUI_DLCN/                 # C# Windows Forms Application
│   ├── GUI_DLCN.sln          # Visual Studio Solution File 
│   └── GUI_DLCN.csproj       # Project Source Code
│
├── Loadcell_LM358/           # STM32 Firmware Source
│   ├── MDK-ARM/              # Keil Project Files
│   ├── Core/
│   │   ├── Src/              # Main logic (main.c, stm32f1xx_it.c) [cite: 52, 53]
│   │   └── Inc/              # Header files
│   ├── Drivers/              # STM32 HAL Drivers (ADC, UART, GPIO) [cite: 55]
│   └── Loadcell_LM358.uvprojx # Keil Project Configuration
