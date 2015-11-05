<h1>ASP-NET-MVC-RequireJS</h1>
Example of ASP.NET MVC app with RequireJS
<h2>JavaScript Structure</h2>
<p>
Scripts<br/>
|-libs<br/>
|  |-jquery-2.1.4.min.js<br/>
|  |-require.js<br/>
|-app.js<br/>
|-config.js<br/>
|-DependencyModule.js<br/>
|-HomeModule.js<br/>
|-ModuleOne.js<br/>
|-ModuleTwo.js<br/>
</p>

<h2>Site Structure</h2>
localhost/ - home page which<br/> 
localhost/pageone - page 1<br/>
localhost/pagetwo - page 2<br/>

<h2>App Description</h2>
RequireJS we place in the main Layout.

<script data-main="@Url.Content("~/Scripts/config")" src="@Url.Content("~/Scripts/libs/require.js")"></script>

Configuration is placed in the ~/Scripts/config.js

On the web pages inside "Script" section we place only modules which are needed.

<script>
  require(['HomeModule']);
</script>



