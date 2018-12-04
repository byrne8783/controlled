This is an attempt to create default FWork 4.7 and Core 2.1 MVC apps which separate 
Entity Framework into separate Class Library projects and determine how the apps interact with the different class libraries.
There are two EF Class Library projects :


ClaLibCore21 :  have a look at its readMe.  This is the sole point we are concentrating on at the moment.

ClaLibStd20 : 


Core 2.1 Mvc has some boilerplate Cookie Consent processing which was'nt in Core 2.0 MVC
FWork 4.7.x Mvc has some scaffolded code which might be related to two-factor authentication/registration

WebAppRzrCore21 is a receiver for the scallolded Indentity Code.