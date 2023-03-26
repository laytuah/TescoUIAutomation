Feature: Register

Scenario: Verify that a user can register a new account successfully
Given that Tesco website is loaded on a browser
When a user clicks on the Register Link
And a user fills in the Email Address field with 'oryayjdhxjx.o@gmail.com'
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