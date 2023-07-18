<?php
header("Access-Control-Allow-Origin: 'http://localhost:80/getContentCss/'");
header('Header Set Access-Control-Allow-Headers *');
echo json_encode(file_get_contents("content.json"));
?>
