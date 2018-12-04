OK, so here we go trying to split the standard Identity thingy into a web app and a class lib project.  Remember that this model (Identity) is all
wrapped-up in MS classes, so you see nothing in your EF project! In fact you see little anywhere because its largely a Razor clas library,unless you scaffold 
it into your App in which case you get a full 2FA authentication suite to enjoy.

(0)  Where was I trying to get to here.
I may have actually got there.  I certainly got the initial migrations to run, and my IdentCtxCore object is being created.
Onwards and upwards.  Lets save it.
Seems to Work : WebAppMvcCore21

(1) Lets have a go at getting the WebAppMvcFworkCore to use it. 
OOPS!  Wont work.  Projects must have compatible frameworks.  WebAppMvcFworkCore is FWork472 while the library project is Core 2.1

(2) Have a go at getting the WebAppMvcFwork to use it. 
Won't work either.  Can't remember why.    
  
(3) Have a go at getting a Razor Pages App to use it. 
Seems to work : WebAppRzpCore21
  
(4) then have a go at extending it to an FirstName,LastName(optional) and a Nickname(required).  That means the Library project needs a derived Context 
and at least one of the other guys needs a fully revised UI with all of the remainder getting a revised UI for NickName
(5) then have a go at this Token stuff from dejanstojanovic.net below



_______________________________________________________________________________________________________________________________
https://dejanstojanovic.net/aspnet/2018/june/token-based-authentication-in-aspnet-core-part-1/  is happy dev stuff.  
Its running the migrations off the library project, when really all that's supposed to be doing is getting a context object.
But the overall articly is excellent, and remarkably useful if anyone ever wants to roll-their-own Identity functionality in the real world again.

https://garywoodfine.com/using-ef-core-in-a-separate-class-library-project/
Is production-oriented stuff.  Not easy to follow

https://www.blinkingcaret.com/2018/03/28/setting-up-ef-core/
Is reasonably comprehensive, but has bits missing and is hard to decipher

https://www.benday.com/2017/12/19/ef-core-2-0-migrations-without-hard-coded-connection-strings/
Does what it says on-the-tin.

