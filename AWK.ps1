get-content "IANAtoWinIds.csv" | foreach-object {
      $data = $_ -split ","
      "{0} -> {1}" -f $data[0],$data[1]
    } > test.txt