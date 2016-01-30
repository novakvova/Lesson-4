<?php
if(isset($_POST['user']) && isset($_POST['password']))
{
    $user = $_POST['user'];
    $pass = $_POST['password'];

    echo $user . ' : ' . $pass;
}
/**
 * Created by PhpStorm.
 * User: Novak
 * Date: 29.01.2016
 * Time: 14:19
 */
?>