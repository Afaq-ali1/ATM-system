<!-- ATM Interface -->

# 🏧 ATM Interface

Welcome, the project contain a simple interface for an ATM (Automated Teller Machine) using C# Windows Application.

## 💻 Project Overview:

ATM interface where a user can log in using a PIN. The system is pre-loaded with data for 5 users, including their PINs and account balances, which is 
hardcoded into the program.

### 🌟 Features:

#### 🔒 User Login:
The user should be able to log in using a PIN. If a user enters the wrong PIN three 
times, the system is blocked, with a message “service is disabled, enter admin pin", and 
special admin pin is required to unlock the system.

#### Withdraw Cash:
- **Quick Withdraw:**
  Pre-defined buttons for quick withdrawal of set amounts.
- **Custom Withdraw:**
  Input a specific amount for withdrawal.

#### 🚫 Error Checking:
The system diligently checks if the withdrawal amount is available in the user’s account. If the input amount exceeds the available balance, an informative error message is displayed.

#### 🔢 Numeric Input Validation:
Rest easy knowing that the system validates user inputs, ensuring only numeric values are accepted. If non-numeric values are detected, the system will display error message indicating invalid input.

#### Pop-up Windows:
For a visually pleasing experience, we use pop-up windows to convey important messages, such as successful withdrawals, insufficient balance, and more.

#### Button Disabling:
Certain buttons are strategically disabled during ongoing processes to prevent accidental button presses, ensuring a smooth user experience.

## 🚀 Implementation Details:

- **Platform:** C# Windows Application.
- **Data Storage:** No external databases or files needed; all data is securely hardcoded.
- **User Experience:** The interface is not just functional but also intuitive, making banking tasks a breeze.

Feel free to explore the code, contribute, and make this ATM Interface even more awesome! Your feedback and suggestions are highly appreciated. 
