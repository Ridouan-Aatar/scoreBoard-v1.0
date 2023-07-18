<?php
header("Access-Control-Allow-Origin: 'http://localhost:80/getContentCss/'");
header('Header Set Access-Control-Allow-Headers *');
echo file_get_contents("content.css") ;
?>
