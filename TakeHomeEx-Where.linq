<Query Kind="Statements">
  <Connection>
    <ID>efd83541-6593-4941-ae92-507ca991e985</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Server>DESKTOP-GGJISR9\SQLEXPRESS</Server>
    <Database>ChinookSept2018</Database>
    <UserName>hansen</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAQ0Fi5Sq400mbuuM9ihwFuAAAAAACAAAAAAAQZgAAAAEAACAAAACf2puG1lx0oaP/aaH8zNw9FKFi2FeX6OG1LH/6iCbR6gAAAAAOgAAAAAIAACAAAABN5LLb/qIV+Bf5PnQbgODom7BdVedsu2qeP0SI99iPKBAAAADA+aiuOmBQ5eHo4b6q5r0WQAAAAIvfT0oqITc3x4tQWUQWVcCVLoWfDPnsuE9ss7pcU6t5mqIXMYyepNk/eToR4N313TicSuNoPgT3IqmOIaIwsC4=</Password>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <PreserveNumeric1>True</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

// For Database Contoso.bacpac

// Question 1: Single Where Clause, All Fields
// Context: "We need to review all invoices created after November 2023 to ensure they were processed correctly."
// Question: "How would you filter the Invoice table to retrieve these invoices?"
Invoices
	.Where(invoice => invoice.DateKey.Date >= new DateTime(2023, 12, 01))
	.Dump();

// Question 2: Single Where Clause, All Fields
// Context: "Our regional analysis team needs to focus on all sales territories located in Canada for a new market expansion project."
// Question: "How would you filter the Geography table to retrieve all records where the country is Canada?"
Geographies
	.Where(geography => geography.RegionCountryName == "Canada")
	.Dump();


// Question 3: Multiple Field Selection
// Context: "After reviewing the previous data output, we noticed records with GeographyType labeled as 'Country/Region.' For our detailed analysis, we only want to focus on cities located in Ontario, Canada."
// Question: "How would you filter the Geography table to retrieve records where the Type is 'City' and the Province Name is 'Ontario'?"
Geographies
	.Where(geography => geography.GeographyType == "City" && 
						geography.StateProvinceName == "Ontario" && 
						geography.RegionCountryName == "Canada")
	.Dump();

// Question 4: Filtering using Contain
// Context: "There has been some confusion with store names that include the term 'No.' in them, which might indicate store numbers or branches. We need to identify all stores with 'No.' in their names to review their details and address any inconsistencies."
// Question: "How would you filter the Store table to retrieve all records where the StoreName contains 'No.'?"
Stores
	.Where(store => store.StoreName.Contains("No."))
	.Dump();


