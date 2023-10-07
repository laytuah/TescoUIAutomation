Feature: Register

Scenario: 01_Verify that a user can register a new account successfully by manually inputting address and leaving the default checks
Given that Tesco website is loaded on a browser
When a user clicks on the Register Link
And a user fills in the Email Address field with 'oryxgfxfccfdhfhgjx.o@gmail.com'
And a user fills in the Password field with 'Mighty511!'
And a user selects 'Mr' from the Title dropdown
And a user fills in the First Name field with 'Abdlateef'
And a user fills in the Last Name field with 'Olasupo'
And a user fills in the Phone Number field with '07733770406'
And a user clicks the Add address manually link
And a user fills in the Address Line 1 field with '186D London Road'
And a user fills in the Town or city field with 'Greenhithe'
And a user fills in the Post code field with 'DA9 9JF'
And a user clicks on the Create account button
Then a new user account 'Abdlateef' must be created

Scenario: 02_Verify that a user can register a new account successfully without joining clubcard and checking all marketing communication
Given that Tesco website is loaded on a browser
When a user clicks on the Register Link
And a user fills in the Email Address field with 'FcgcCChgv.o@gmail.com'
And a user fills in the Password field with 'Mighty511!'
And a user clicks the I'm not interested in joining clubcard Checkbox
And a user selects 'Miss' from the Title dropdown
And a user fills in the First Name field with 'Adeola'
And a user fills in the Last Name field with 'Adewoyin'
And a user fills in the Phone Number field with '07732471111'
And a user fills in the Address field with 'DA9 9JF'
And a user clicks '186D LONDON ROAD' from the address dropdown
And a user clicks the Tesco Bank Checkbox
And a user clicks the Tesco Mobile Checkbox
And a user clicks on the Create account button
And a user fill in the text field on the popup screen with 'I do not have the luxury of time'
And a user clicks on the Register Now button
And a user clicks on Homepage buton
Then a new user 'Adeola' must be created