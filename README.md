# LamiaOY Practical Task

A simple Asp.net core REST API with three endpoints:
● /user - requires a username and password (no registration implemented for now) and returns a token needed for future requests
● /movie - an endpoint that takes title of movie, year and version of plot, requests results from IMDB Open API and returns them to the user
● /book - an endpoint that takes ISBN number of  a book, requests results from OpenLibrary API and returns the book information to user

A simple PHP client that handles the login, prompts the user for information about the requests they'd like to make and forwards these requests to the API