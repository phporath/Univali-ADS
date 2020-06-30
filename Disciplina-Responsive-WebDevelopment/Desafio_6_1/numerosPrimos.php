<?php
    for ($i= 1; $i<= 100; $i++)
    {   
        $nuDiv = 0;
        for ($j= $i; $j >= 1; $j--)
        {
            if ($i % $j == 0)
                $nuDiv++;
        }
        if ($nuDiv == 2)
            break;
            echo $i . ', ';
    }
?>