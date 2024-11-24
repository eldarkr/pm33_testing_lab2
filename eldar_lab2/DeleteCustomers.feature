Feature: Delete customers from the banking project
  As a bank manager
  I want to delete all customers
  So that I can manage the customer list effectively

  Scenario: Deleting all customers
    Given I am on the login page
    When I navigate to the customers page
    And I delete all customers
    Then there should be no customers left
