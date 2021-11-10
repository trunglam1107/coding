<?

	$host = (isset($_SERVER['HTTPS']) ? "https" : "http")."://".$_SERVER[HTTP_HOST];
	$uri = $_SERVER["REQUEST_URI"];

	$reUrl = $host.$uri;

	// $pcode	= 'DKC0001';
	// $tlan	= 'vn';
	// $email	= 'dikay.kim@gmail.com';
	// $name	= 'Dikay Kim';
	// $dob	= '19770804';
	// $region	= 'HCM';
	// $gender	= 2;
	// $school	= 'Kynda International School';
	// $grade	= 11;
	// $re_url	= '';

	$pcode	= 'CP78900025';
	$tlan	= 'vn';
	$email	= 'anlt.sg.vn@gmail.com';
	$name	= 'Lê Tấn An';
	$dob	= '19760116';
	$region	= 'HCM';
	$gender	= 2;
	$school	= 'TC School';
	$grade	= 8;
	$re_url	= 'https://wisementor.vn/partners/789';

?>


<!DOCTYPE html>
<html>
    <head>
        <title>Wise Mentor TEST1</title>
        <meta name="description" content="">
        <meta name="keywords" content="">
        <meta charset="utf-8">
        <meta name="author" content="Dikay Kim">
        <!--[if IE]><meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'><![endif]-->

        <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0, user-scalable=no" />

		<meta property="og:url" content="" />
		<meta property="og:type" content="" />
		<meta property="og:title" content="" />
		<meta property="og:description" content="" />
		<meta property="og:image"  content="" />

		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
		<script src="https://www.wisementor.vn/api/js/wm_process.js?pcode=<?=$pcode?>&tlan=<?=$tlan?>&email=<?=$email?>&name=<?=$name?>&dob=<?=$dob?>&region=<?=$region?>&gender=<?=$gender?>&school=<?=$school?>&grade=<?=$grade?>&re_url=<?=$reUrl?>"></script>

		<!-- font -->
		<link href="https://fonts.googleapis.com/css2?family=Roboto+Slab:wght@300&display=swap" rel="stylesheet">
		<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@400&display=swap" rel="stylesheet">
		<link href="https://fonts.googleapis.com/css2?family=Source+Sans+Pro&display=swap" rel="stylesheet">
		<link href="https://fonts.googleapis.com/css2?family=Merriweather:wght@300&display=swap" rel="stylesheet">


	<style>

	body,
	input,
	button {
		font-family: 'Merriweather', serif;
		font-size:16px;
	}

	.coupon,
	.mylist {
		text-align:center;
		}

	.coupon h4,
	.mylist h4 {
		font-size:48px;
		margin-bottom:10px;
		}

	.input_style input {
		display: block;
		width: 300px;
		height: 34px;
		padding: 6px 12px;
		margin:20px auto;
		font-size: 18px;
		line-height: 1.42857143;
		color: #555;
		text-align:center;
		background-color: #fff;
		background-image: none;
		border: 1px solid #ccc;
		-webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
		box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
		-webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
		-o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
		transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
	}

	.input_style:focus input {
		border-color: #66afe9;
		outline: 0;
		-webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075), 0 0 8px rgba(102, 175, 233, .6);
		box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075), 0 0 8px rgba(102, 175, 233, .6);
	}



	button {
		display: inline-block;
		padding: 6px 12px;
		margin: 5px;
		font-size: 14px;
		font-weight: 400;
		line-height: 1.42857143;
		text-align: center;
		white-space: nowrap;
		vertical-align: middle;
		-ms-touch-action: manipulation;
		touch-action: manipulation;
		cursor: pointer;
		-webkit-user-select: none;
		-moz-user-select: none;
		-ms-user-select: none;
		user-select: none;
		background-image: none;
		border: 1px solid transparent;
		border-radius: 4px;
	}


	.wmtable {
		width: 800px;
		max-width: 100%;
		margin-bottom: 20px;
		margin:0 auto;
		vertical-align:middle;
	}


	.wmtable>tbody>tr>td, .wmtable>tbody>tr>th, .wmtable>tfoot>tr>td, .wmtable>tfoot>tr>th, .wmtable>thead>tr>td, .wmtable>thead>tr>th {
		padding: 8px;
		line-height: 1.42857143;
		vertical-align: top;
		border-top: 1px solid #ddd;
		vertical-align:middle;
	}
	.wmtable>thead>tr>th {
		vertical-align: bottom;
		border-bottom: 2px solid #ddd;
		vertical-align:middle;
	}
	.wmtable>caption+thead>tr:first-child>td, .wmtable>caption+thead>tr:first-child>th, .wmtable>colgroup+thead>tr:first-child>td, .wmtable>colgroup+thead>tr:first-child>th, .wmtable>thead:first-child>tr:first-child>td, .wmtable>thead:first-child>tr:first-child>th {
		border-top: 0;
	}
	.wmtable>tbody+tbody {
		border-top: 2px solid #ddd;
	}
	.wmtable .wmtable {
		background-color: #fff;
	}

	</style>

	</head>


	<body>

		<div class="coupon">
			<h4>Check Coupon</h4>
			<div id="chkCoupon"></div>
		</div>

		<hr style="margin-top:50px">
		
		<div class="mylist">
			<h4>My test list</h4>
			<div id="testList"></div>
		</div>

	</body>

</html>