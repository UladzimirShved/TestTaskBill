
Feature: DownloadTests

Scenario: DownloadFile
	Given Go to Download page
	When Switch to '3' iframe index on Download page
		And Click Start Download button on Download page
	Then File download title displayed is 'true' on Download page
		And File is downloaded on Download page
	
