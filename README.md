# Order Viewer - TIMG

A simple order viewer application that is developed using MVC, Angular, Web Api, Sql Server (2016) & Entity Framework. 
The application has 2 pages
* The home page just displays a brief information about TIMG
* The orders page displays the client names and a toggle to their order details

## How to run

* Clone or download the repo to your system
* Create a database in Sql Server (preferrably with OrderViewer as the name)
* Navigate to OrderViewer.Database -> Publish foler and double click on the OrderViewer.Database.publish xml
* The above step will open a GUI to select DB and options to generate or publish the script. Please choose the DB that you had created and click on publish
* This created the DB. Please note that if you are having difficulties, it may be due to the SQL Server version, kindly check that in the OrderViewer.Database project properties
* Once done, set OrderViewer.Web as your startup project
* In OrderViewer.Web project properties ensure that Web Url is set to http://localhost:41728/
* In the web.config, modify the connection string (if required)
* Run the solution now (preferrably in chrome) and it should also resolve the Nuget packages. If you get an error, just right click on the solution and click restore nuget packages
* If you are using VS 2015 or above, you may get an error with roslyn csc
* To fix it, open the web project in notepad and paste the below
	<Target Name="CopyRoslynFiles" AfterTargets="AfterBuild" Condition="!$(Disable_CopyWebApplication) And '$(OutDir)' != '$(OutputPath)'">
    <ItemGroup>
      <RoslynFiles Include="$(CscToolPath)\*" />
    </ItemGroup>
    <MakeDir Directories="$(WebProjectOutputDir)\bin\roslyn" />
    <Copy SourceFiles="@(RoslynFiles)" DestinationFolder="$(WebProjectOutputDir)\bin\roslyn" SkipUnchangedFiles="true" Retries="$(CopyRetryCount)" RetryDelayMilliseconds="$(CopyRetryDelayMilliseconds)" />
  </Target>
* Hurray! you should see the TIMG Order Viewer
* There is a sample unit test for repository as well. Should you wish to execute it, change the connection string and run the test

## The Coding Challenge approach - Giving a brief flavor of everything

* The application was completed as per the email shared
* I took close to a couple of hours to complete the challenge
* I added Primary key to the tables and also added foreign key relationship between Order & Order Item
* I created a publish xml file, in the db project, so that it is easy to deploy the db along with post deployment script
* I have used Entity Framework in the repository layer and have upheld coding standards
* I added web api to the web project and also took the angular approach along with bootstrap to complete the UI
* I have used the Model, View & Controllers to the extent required for the project and have modularized angular components to show my coding style
* From a UI perspective, I have used bootstrap and instead of showing a conventional table, I have used a collpsible panel to just show the client names first and then toggle for the order details
* In angular, I managed to use formatters, controllers, modules & service provider

## What more can we do if this was a real time project

* We could elaborate more on the table designs and capture additional details for both the client details and also normalize the products
* The Total price could be computed based onthe unit price, quantity & SGT
* The repository layer will host additional classes to even add/delete order details
* We could build a small workflow for the order approval, delivery & payment etc
* I would add another class library for the service layer that acts as a middle layer between the controller & the repository. We coiuld have all our business logic done there and transform the data entity to a business entity
* More unit tests for the repository & the service layer can be added
* UI testing can also be added using karma, chai & Sinon frameworks
* We could include Sawgger to document & test the web api
* More UI would be developed for capturing order details & managing the same
* Paging, sorting & filtering should be added to make the UI user friendly
* Replace collapsible panel with a full fledged grid for easy access of data
