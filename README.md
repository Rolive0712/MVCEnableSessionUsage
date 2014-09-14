MVCEnableSessionUsage
=====================

This project describes ways to enable session usage in MVC &amp; MVC web api.

Steps:
1. Create class "SessionControllerHandler.cs" in any Helper folder or a folder where we put all the utility functions or    extension methods
2. finally register the "SessionRouteHandler" from the class above in the routetable collection of web api or mvc router.
3. After step 1 & 2, Session object can be used anywhere within MVC 4 Web API application.
