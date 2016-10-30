#r "packages/Suave/lib/net40/Suave.dll"
#load "HelloPerson.fs"
open Suave
open HelloPerson
startWebServer defaultConfig (Successful.OK ("Hello, " + (Person.toString Person.bob)))
