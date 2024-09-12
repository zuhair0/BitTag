# BITTAG - AUTOMATIC VEHICLE TAGGING SYSTEM USING QR CODE TECHNOLOGY

### PROBLEM STATEMENT
Some people work in more than one organization or sometimes work in a single organization but go to other places as well. All the organizations usually require a vehicle sticker to be placed at the windshield. Sometimes these stickers are so much that they hinder the display of the vehicle. Similarly, these stickers only prove that a certain vehicle is affiliated with this organization and thus provides the parking space to it accordingly. The security and the record of entry and exit of vehicle is never maintained through these stickers. A solution to these problems does not exist and a person’s vehicle’s security stays compromised.

### PROBLEM SOLUTION
The idea of BitTag solves the problem of not only maintaining multiple car stickers but also enhancing the security of a vehicle. A BitTag is basically a QR code comprising vehicle and its owner’s information. Instead of purchasing different car stickers, a person would be prompted to purchase a BitTag. These BitTag would be sold to the organization and the organization would then distribute them to their bona fide employees or affiliates after taking the charges which they want. The same sticker would then be accessible to all the organizations that specific vehicle is affiliated with. Each organization will have a distinct database and won’t be able to access the database of other organizations. Whenever the registered vehicle enters the premises, the UPC will be automatically scanned, and the database would be updated by the entry date-time. If the owner opts for the security feature, he/she would be provided with the One-Time-Passcode (OTP) which will stay valid until the vehicle stays inside the organization. However, if the owner doesn’t opt for the security feature, the OTP will not be generated, and the vehicle would be able to exit without providing the OTP or fingerprint impression. If this option is enabled, the owner will be asked for the OTP and if needed, will be opted to provide a fingerprint impression (The fingerprint will be matched with the one provided during the registration process). Finally, the exit information of the vehicle will be saved accordingly. 

### OBJECTIVES
1: Increases vehicle and owner security, reducing the theft and robberies of the vehicle from within the organization.
2: Eliminating the hassle of maintaining multiple car stickers depicting different organizations.
3: Keeping track of vehicles’ entry and exit in a synchronous and automatic way.
4: Removing the hassle of paying parking fees, by switching to a cashless wallet system with top-up facility. 
5: Reducing the traffic outside the organization’s gate by 25-30%

### SCOPE
BitTag can be made available to all the organizations who use their own vehicle stickers. All an organization needs are two cameras or the barcode readers at the gate which will be placed in a way that it is facing the vehicle’s windshield. Also, a system – preferably a desktop will be required in which all the vehicle’s data will be automatically entered during the entry and exit. Another thing which will be required is a fingerprint scanner which will be used if the person opts for the security feature. Keeping the accessories into consideration, when a vehicle enters the premises, the barcode will scan the BitTag placed on the system’s windshield, this barcode will be connected to the system and thus, will store and display the entry and exit time. In case the BitTag is not placed on the vehicle, the registration fee will be paid to the organization and the organization will register your vehicle with its database along with registering your fingerprint. Finally, during exit, the barcode or a camera will once again scan the BitTag which will then save the data of exit in the database. 

### TECHNOLOGIES USED
1. ASP.NET Core Web API
2. ASP.NET Core Blazor Server
3. .NET 7.0
4. Microsoft Azure
5. Syncfusion

### ENDPOINTS
1. <a href="https://bittagwebapp.azurewebsites.net">Admin Portal</a>
2. <a href="https://bittaguser.azurewebsites.net">User Panel</a>
3. <a href="https://bittagapi.azurewebsites.net/swagger">API</a>
