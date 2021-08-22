$time = Read-Host -prompt "Enter timezone"
Get-Content "IANAtoWinIds.csv" | Foreach-Object {
    $data = $_ -split ","
    if($data[0] -eq $time){
        $data[1]
    }    
}