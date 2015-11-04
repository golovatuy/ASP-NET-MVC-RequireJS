require.config({
	baseUrl: "../Scripts",
	paths: {
		jquery: ["https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min", "/Scripts/libs/jquery-2.1.4.min"]
	}
});

require(["app"], function (app) {
	app.init();
});