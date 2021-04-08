Feature: StudentRegistration
@mytag
Scenario Outline: as a user I can navigate to prepmajor.com and open the successfully register
Given a user navigates to the prepmajor site
When I click  on SignUp button
And under the Registration section I fill in my "<Username>"
And I fill in my "<Email>"
And I fill in the "<Password>"
And I confirm the "<Cpassword>"
And I check the Terms Of Use And Condition checkBox
And I click on the register button
Then the student should successfully Register and see the username displayed

Examples: 
| Username			  | Email							  | Password	   | Cpassword     |
| Simonheart9685	  | somonheart9685@gmail.com		  | simonsays85    | simonsays85   |
| Simonheart9685      | somonheart9685@gmail.com          | Simonsays85    | Simonsays85   |
| Simonheart9685      | somonheart9685@gmail.com          | Simonsays85    | Simonsays     |