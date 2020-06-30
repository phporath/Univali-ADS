<?php
  $start = new \DateTime('2017-12-01');
  $end = new \DateTime('2017-12-10');
  $periodArr = new \DatePeriod($start , new \DateInterval('P1D') , $end);

  foreach($periodArr as $period) {
      echo $period->format('d/m/Y').'<br />';
  }

  //data de término
  echo $end->format('d/m/Y');
?>