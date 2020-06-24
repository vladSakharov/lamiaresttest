<?php
class MovieSearch
{
    private $urlAddition = 'movie';

    public function welcome($client)
    {
        echo "What is the title of the movie you want to find?" . PHP_EOL;
        $title = trim(fgets(STDIN));
        echo "Release year?" . PHP_EOL;

        $year = trim(fgets(STDIN));
        echo "Would you like a full or a short plot description?" . PHP_EOL;

        while (true) {
            $type = trim(fgets(STDIN));
            if (strcasecmp($type, 'full') === 0) {
                $type = 'full';
                break;
            } elseif (strcasecmp($type, 'short') === 0) {
                $type = 'short';
                break;
            } else {
                echo sprintf(
                    "sorry I don't know what %s means, i only know types 'full' and 'short'.%s",
                    $type,
                    PHP_EOL
                );
            }
        }
        $arguments = [$title, $year, $type];

        $result = $client->get($this->urlAddition, $arguments);

        print_r($result);
    }
}
