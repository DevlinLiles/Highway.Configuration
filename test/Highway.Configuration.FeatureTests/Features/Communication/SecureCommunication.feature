Feature: SecureCommunication
	In order to have secured configuration
	As a client
	I want to have encrypted communication

@Communications
Scenario: Service Communication should be encrypted outside of the communication pipeline
	Given I have a configuration store
	And I have settings with sensitive data
	When I get the application settings
	Then the results should be encrypted by a configureable key and a common salt
