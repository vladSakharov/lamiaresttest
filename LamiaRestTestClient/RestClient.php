<?php
class RestClient
{
    private $baseUrl;

    private $token;

    public function __construct($url, $username, $password)
    {
        $this->baseUrl = $url;
        $this->token = $this->login($url, $username, $password);
    }

    private function login($url, $username, $password)
    {
        $url = sprintf("%s/%s", $url, 'user/authenticate');
        $data = [
            'username' => $username,
            'password'=> $password
        ];
        $payload = json_encode($data);

        $curl = curl_init();
        curl_setopt_array($curl, array(
            CURLOPT_URL => $url,
            CURLOPT_POST=> true,
            CURLOPT_POSTFIELDS=> $payload,
            CURLOPT_RETURNTRANSFER => true,
            CURLOPT_TIMEOUT => 30,
            CURLOPT_HTTPHEADER => array(
                'Content-Type:application/json'
            ),
            CURLOPT_SSL_VERIFYHOST => false,
            CURLOPT_SSL_VERIFYPEER => false,
        ));

        $result = curl_exec($curl);
        $status = curl_getinfo($curl, CURLINFO_HTTP_CODE);

        if (400 <= $status && $status < 500) {
            die("$status Bad request, curl_error " . curl_error($curl). ", curl_errno " . curl_errno($curl));
        }
        if (500 <= $status && $status < 600) {
            die("$status Internal Server error, curl_error " . curl_error($curl). ", curl_errno " . curl_errno($curl));
        }
        return json_decode($result)->token;
    }

    public function get($urlAddition, $data)
    {
        $url = sprintf("%s/%s", $this->baseUrl, $urlAddition);
        foreach ($data as $arg) {
            $url = sprintf("%s/%s", $url, $arg);
        }
        $curl = curl_init();
        curl_setopt_array($curl, array(
            CURLOPT_URL => $url,
            CURLOPT_RETURNTRANSFER => true,
            CURLOPT_TIMEOUT => 30,
            CURLOPT_CUSTOMREQUEST => "GET",
            CURLOPT_HTTPHEADER => array(
                "cache-control: no-cache",
                "Authorization: Bearer " . $this->token
            ),
            CURLOPT_SSL_VERIFYHOST => false,
            CURLOPT_SSL_VERIFYPEER => false
        ));

        $result = curl_exec($curl);
        $status = curl_getinfo($curl, CURLINFO_HTTP_CODE);

        if (400 <= $status && $status < 500) {
            die("$status Bad request, curl_error " . curl_error($curl). ", curl_errno " . curl_errno($curl));
        }
        if (500 <= $status && $status < 600) {
            die("$status Internal Server error, curl_error " . curl_error($curl). ", curl_errno " . curl_errno($curl));
        }

        curl_close($curl);
        return json_decode($result);
    }
}
