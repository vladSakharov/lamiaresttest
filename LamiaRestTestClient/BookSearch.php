<?php
class BookSearch
{
    private $urlAddition = 'book';

    public function welcome($client)
    {
        echo "What is the ISBN of the book you want to find?" . PHP_EOL;
        $isbn = trim(fgets(STDIN));

        $arguments = [$isbn];

        $result = $client->get($this->urlAddition, $arguments);

        print_r($result);
    }
}
