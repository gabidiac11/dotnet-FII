# Lab 2
## _Introduction to .NET 2021_
[![N|Solid](https://plati-taxe.uaic.ro/img/logo-retina1.png)](https://www.info.uaic.ro/)

Diac P. Gabriel
3A2
Diac P. Gabriel
3A1

Solution for KATA-4:
http://codekata.com/kata/kata04-data-munging/

### Parser (LAB_2/Utils/Parser/)
[![N|Solid](https://github.com/gabidiac11/dotnet-FII/blob/main/LAB_2/Utils/wiki/parsing-drawing.png)](https://github.com/gabidiac11/dotnet-FII/blob/main/LAB_2/Utils/wiki/parsing-drawing.png)

We also wrote tests for parser in `LAB_2/lab2.PartOne.Tests/`.

This module is only parsing data from file to a list of list of strings.

### Code design

Part One: Weather Data and Part Two: Soccer League Table are 2 separate modules that implement common interfaces and abstract classes from `LAB_2/lab2.Core`. 
PartOne and PartTwo:
         - defines the entity data to parse into
         - defines how a list of strings instantiate the entity (by  implmenting the IParser from lab2.Core)
         - the file to extract data from (by implementing the IProvider interface and by inheriting Provider abstract class from lab2.Core), 
         - what 2 properties to use for solving the kata problems
         - how to print the result on the screen the result
