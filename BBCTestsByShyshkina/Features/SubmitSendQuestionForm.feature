Feature: SubmitSendQuestionForm
	As a user of BBC site
	I want to fill form on the Send Your Question page
	So that I can send question to BBC

@submit_invalid_form
Scenario Outline: Submit form
	Given User is on the BBC Home page 'https://www.bbc.com/'
	When User goes to the Send Your Question page
	And User submits form without filling all required fields
		| Key          | Value          |
		| question     | <question>     |
		| Name         | <name>         |
		| Email        | <email>        |
		| Age          | <age>          |
		| Postcode     | <postcode>     |
		| Telephone    | <tel>          |
		| I am over 16 | <1st checkbox> |
		| I accept     | <2d checkbox>  |
	Then the error message is shown
Examples:
| question | name   | email          | age | postcode | tel        | 1st checkbox | 2d checkbox |
|          | Myname | test@test.test | 20  | 01001    | 0999999999 | check        | check       |
| My story |        | test@test.test | 20  | 01001    | 0999999999 | check        | check       |
| My story | Myname |                | 20  | 01001    | 0999999999 | check        | check       |