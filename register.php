<?php 

session_start();
	
	include 'config.php';
	include 'functions.php';

	if($_SERVER['REQUEST_METHOD'] == "POST"){
		//something was posted
		$nama_lengkap = $_POST['nama-lengkap'];
		$umur = $_POST['umur'];
		$pendidikan = $_POST['pendidikan'];
		$email = $_POST['email'];
		$password = %_POST['password'];

		if(!empty($nama_lengkap) && !empty($umur) && !empty($pendidikan) && !empty(email)
		    && !empty(password)){
				
			}
	}



?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">

	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

	<link rel="stylesheet" type="text/css" href="login-style.css">

	<title>Register Form - Pure Coding</title>
</head>
<body>
	<div class="container">
		<form action="" method="POST" class="login-email">
            <p class="login-text" style="font-size: 2rem; font-weight: 800;">Register</p>

			<div class="input-group">
				<input type="text" placeholder="Nama Lengkap" name="nama-lengkap" >
			</div>
			<div class="input-group">
				<input type="text" placeholder="Umur" name="umur" >
			</div>
			<div class="input-group">
				<input type="text" placeholder="Pendidikan" name="pendidikan" >
			</div>
			<div class="input-group">
				<input type="email" placeholder="Email" name="email" >
			</div>
			<div class="input-group">
				<input type="password" placeholder="Password" name="password" >
            </div>
			<div class="input-group">
				<button name="submit" class="btn">Register</button>
			</div>
			<p class="login-register-text">Have an account? <a href="index.php">Login Here</a>.</p>
		</form>
	</div>
</body>
</html>