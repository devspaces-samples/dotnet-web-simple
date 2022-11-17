/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Red Hat, Inc. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Urls.Add("http://0.0.0.0:5000/");

app.MapGet("/", () => "Hello World!");

app.Run();
