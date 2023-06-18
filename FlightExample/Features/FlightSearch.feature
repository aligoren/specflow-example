Feature: FlightSearch
	Flight search results
	
Scenario: Define two cities by their codes to search flights
	Given define the first city as "<from>"
	And define the second city as "<to>"
	When two city codes are defined
	Then the result should be "<result>"
	Examples: 
		| from | to  | result        |
		| IST  | ESB | IST-ESB found |
		| IST  | AMS | IST-AMS found |
		| ESB  | CGD | ESB-CGD found |
		| AMS  | BER | AMS-BER not found  |