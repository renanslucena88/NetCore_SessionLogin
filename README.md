# NetCore_SessionLogin
Using Session Login in Asp Net Core


THIS IS A SIMPLE EXAMPLE!!

There is a better way and I'm working in a good example.
We can use the HttpContext that contains in HttpContextAccessor!
I'm workig in a good example using Identity to upload! =)



How works this example???
The classes I want to make sure that the users won't access without be logged I write [Login] before the Class, then this filter will apply for all methods within this class. If I like to apply this filter only for some methods, I could write only before the method and not before the class.
On Library/Filters/LoginAttribute.cs I created an override function od OnActionExecuted to check if there is a session "Login" filled and if is null, it will redirect to Login Page: 
        public override void OnActionExecuted(ActionExecutedContext context)
        {

            if (context.HttpContext.Session.GetString("Login") == null)
            {
                context.Result = new RedirectToActionResult("Login", "Home", null);
                base.OnActionExecuted(context);
            }
        }




You can find more examples in my repositories using RabbitMQ, SOLID, DDD, FluentValidatiom, EntityFrameworkCore, CodeFirst, Dependence Injection.
If you have any questions about .net Core or net Framework, please let me know. I will be happy to help you.
