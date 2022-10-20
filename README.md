# TwilioVerify-TOTP

TOTP stands for Time-based One-Time Passwords and is a common form of two factor authentication (2FA). Unique numeric passwords are generated with a standardized algorithm that uses the current time as an input. The time-based passwords are available offline and provide user friendly, increased account security when used as a second factor.(Source:twilio.com)

The general request from TOTP systems is that the user enters a certain system. TOTP does not care about who the user is. However, in some high security situations, the input elements need to be supervised. Therefore, in this study, I tried to solve this problem by assigning factors. Each factor represents users in a store. Thus, if you define 6 factors, you will have the chance to control the number of stores*6 maximum users entering and exiting the TOTP system.
