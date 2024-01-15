## ATM Interface
<p>The project contain a simple interface for an ATM (Automated Teller Machine) using C# Windows Application.</p>
<h3>Project Description:</h3>
ATM interface where a user can log in using a PIN. The system is pre-loaded with data for 5 users, including their PINs and account balances, which is 
hardcoded into the program.<br>
 
<h4>Features:</h4>
<h5>• User Login:</h5> The user should be able to log in using a PIN. If a user enters the wrong PIN three 
times, the system is blocked, with a message “service is disabled, enter admin pin", and 
special admin pin is required to unlock the system.<br>
<h5>• Withdraw Cash:</h5> The user should be able to withdraw cash in two ways:<br>
o Quick Withdraw: Pre-defined buttons for quick withdrawal of set amounts.<br>
o Custom Withdraw: Input a specific amount for withdrawal.<br>
<h5>• Error Checking:</h5> The system should check if the withdrawal amount is available in the user’s 
account. If the input amount is more than the available balance, an error message should be 
displayed.<br>
<h5>• Numeric Input Validation:</h5> The system should validate that the user inputs only numeric values.<br>
<h5>• Pop-up Windows:</h5> Use pop-up windows to display messages to the user, such as successful 
withdrawal, insufficient balance, etc.<br>
<h5>• Button Disabling:</h5> Certain buttons should be disabled while a process is underway to prevent 
accidental button presses.<br>

<h4>Info:</h4>
• The project is implemented as a C# Windows Application.<br>
• No database or external files are needed as all data is hardcoded.<br>
• The interface is user-friendly and intuitive.<br>
