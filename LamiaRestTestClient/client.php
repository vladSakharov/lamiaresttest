<?php
require_once("BookSearch.php");
require_once("MovieSearch.php");
require_once("RestClient.php");

$ini = parse_ini_file('client.ini');
$restClient = new RestClient($ini['api_url'], $ini['username'], $ini['password']);

echo "would you like to search for a movie or a book?".PHP_EOL;
$category = trim(fgets(STDIN));
if (strcasecmp($category, 'book') === 0) {
    $bookSearch = new BookSearch();
    $bookSearch->welcome($restClient);
} elseif (strcasecmp($category, 'movie') === 0) {
    $movieSearch = new MovieSearch();
    $movieSearch->welcome($restClient);
} else {
    echo sprintf("sorry I don't know what %s is", $category);
}
