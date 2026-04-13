 CyberSecurity Awareness Bot

 Overview

The **CyberSecurity Awareness Bot** is a simple C# console application designed to educate users about basic cybersecurity practices. It provides interactive responses to common security-related questions and promotes safe online behavior.

---

 Features

 **Voice Greeting**

  * Plays a welcome audio (`greeting.wav`) when the application starts

   **ASCII Logo Display**

  * Displays a styled cybersecurity-themed banner

   **Interactive Chatbot**

  * Responds to user questions in real time
  * Personalized greeting using the user’s name

   **Typing Effect**

  * Simulates real-time typing for a better user experience

   **Cybersecurity Topics Covered**

  * Password safety
  * Phishing awareness
  * Safe browsing practices
  * General online security tips

---

 Project Structure

```
CyberSecurityBot/
│
├── Program.cs            # Entry point of the application
├── voice_greeting.cs     # Handles audio greeting
├── Logo.cs               # Displays ASCII logo
├── human_text.cs         # Chatbot logic and interaction
└── greeting.wav          # Audio file (must be in output folder)
```

---

 Requirements

* .NET Framework / .NET SDK (recommended: .NET 6 or later)
* Windows OS (for sound playback using default media player)

---

 How to Run

1. Clone or download the project
2. Open in Visual Studio
3. Build the solution
4. Ensure `greeting.wav` is in the output directory:

   ```
   bin/Debug/ or bin/Release/
   ```
   Run the application

---

 Example Interaction

```
==============================================
Cyber Security Awareness Bot Online...
==============================================

Enter your name: Mandla

Welcome, Mandla!
I am your Cyber Security Awareness Assistant.
Ask me anything about online safety.

Ask me something: what is phishing
Phishing is when attackers trick you into giving personal information.
```

---
 Notes

* If `greeting.wav` is missing, the app will continue without sound.
* Input is case-insensitive but based on keyword matching.
* Unknown questions will prompt the user to rephrase.

---

 Future Improvements

* Add more advanced AI responses
* Support for more cybersecurity topics
* GUI version (Windows Forms or WPF)
* Voice recognition input
* Multi-language support

---

  Author

Developed as a cybersecurity awareness project using C#.

---

 License

This project is for educational purposes.
