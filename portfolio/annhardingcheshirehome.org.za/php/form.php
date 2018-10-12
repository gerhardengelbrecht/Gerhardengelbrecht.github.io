<?php
$to = 'markr@3rdline.co.za';
$subject = $_POST['subject'];
$headers = 'From: 3rd Line website <website@3rdline.co.za>' . "\r\n" . 'Content-type: text/html; charset=utf-8';
$message = '
<html>
	<head>
		<title>3rd Line website enquiry</title>
	</head>
	<body>
		<h3>Name: <span style="font-weight: normal;">' . $_POST['name'] . '</span></h3>
		<h3>Email Adress: <span style="font-weight: normal;">' . $_POST['email'] . '</span></h3>
		<h3>Telephone: <span style="font-weight: normal;">' . $_POST['phone'] . '</span></h3>
        <h3>Subject: <span style="font-weight: normal;">' . $_POST['subject'] . '</span></h3>
		<div>
			<h3 style="margin-bottom: 5px;">Comment:</h3>
			<div>' . $_POST['comment'] . '</div>
		</div>
	</body>
</html>';

if(isset($_POST['g-recaptcha-response'])){
    $captcha=$_POST['g-recaptcha-response'];
}

if (!empty($_POST['name']) && !empty($_POST['email']) && !empty($_POST['comment'])) {
	if (filter_var($_POST['email'], FILTER_VALIDATE_EMAIL)) {
        if(!$captcha){
            echo '<span style="color: red;"><h6>Please check the captcha checkbox.</h6></span>';
        } else {
            mail($to, $subject, $message, $headers) or die('<span style="color: red;"><h6>Error sending Mail</span>');
	        echo '<span class="send-true" style="color: #00dd63;"><h6>Your email was sent!</h6></span>';
        }
	} else {
        echo '<span style="color: red;"><h6>You need to enter a valid email address</h6></span>';
    }
} else {
	echo '<span style="color: red;"><h6>All fields must be filled</h6></span>';
}
?>