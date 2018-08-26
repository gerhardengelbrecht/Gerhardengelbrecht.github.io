<!doctype html>
<html>
<head>
    <?php include 'head.php' ?>
</head>
<body class="one-page fixed-header boxed">
  <div class="page-box">
    <div class="page-box-content">
          <?php include 'Header.php' ?>
      <div id="main">
        <div class="container">
            <div class="row">
              <div class="col-sm-6 contact-info bottom-padding-mobile bottom-padding">
                <p>Feel free to enter your contact details on the right and we will get back to you as soon as possible.</p>
                <p>Plot 40, Fourth Road, Northwold, Randburg GPS co-ordinates</p>
                <p>P O Box 1357, Randburg, 2125</p>
                <p>Manager – Joy Baloyi – manager @cheshirehomes.org.za</p>
                <p>Head of Care – Vicky Manzini – headofcare@cheshirehomes.org.za</p>
                <p>Fundraising and Charity Shop – Jackie Kyle – jackie@cheshirehomes.org.za
                <p>Tel : 011 792 3510 / 11</p>
                <p>Facebook : https://www.facebook.com/AnnHardingCheshireHome/</p>
                <p>https://www.facebook.com/Ann-Harding-Cheshire-Home-Charity-Shop-642271062583575/</p>
              </div>
              <div class="col-sm-6">
                <form id="contactform" class="form-box register-form contact-form" action="?" method="POST">
                  <h3 class="title">Quick Contact</h3>
                  <div id="success"></div>
                  <label>Name: <span class="required">*</span></label>
                  <input class="form-control" type="text" name="name">
                  <label>Email Address: <span class="required">*</span></label>
                  <input class="form-control" type="email" name="email">
                  <label>Telephone: <span class="required">*</span></label>
                  <input class="form-control" type="text" name="phone">
                  <label>Subject: <span class="required">*</span></label>
                  <input class="form-control" type="text" name="subject">
                  <label>Comment: <span class="required">*</span></label>
                  <textarea class="form-control" name="comment"></textarea>
                  <div class="clearfix"></div>
                  <p>Please verify that you are not a robot</p>
                  <div class="buttons-box clearfix">
                    <div class="g-recaptcha" data-sitekey="6LdYZ10UAAAAAI5lh6XmxKjiXMRQjOHAl-YJ1swH"></div>
                  </div><!-- .buttons-box -->
                  <div class="buttons-box clearfix" style="margin-top: 10px;">
                    <button id="submit" class="btn btn-default">Submit</button>
                    <span class="required"><b>*</b> Required Field</span>
                  </div><!-- .buttons-box -->
                </form>
              </div>
            </div>
      </div><!-- #main -->
    </div><!-- .page-box-content -->
    <?php include 'Footer.php' ?>
  </div><!-- .page-box -->
  <div class="clearfix"></div>
  <?php include 'foot.php' ?>
</body>
</html>