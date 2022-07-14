# sampantallas
Bool valid = true;
If (valid)
(   
    Pilestrean fs;
    Streanriter escribir;
    string línea;
    string rutabase = Directory.GetcurrentDirectory();
    string rutaArch = rutaBase.Replace(0"\bin\Debug",0"\Ficheros\usuario.txt");
    fs = new filestreaz(rutaArch, filemode,Append);
    
    Escribir = new streawriter(fs);
    
    lines = txtnombre.Text +";";
    lines += txtapellido.Text + ";";
    lines += txtcorreo.Text + ";";
    lines+= txtcontraseña.Text + ";";
    lines += txtedad.Text + ";";
    escribir.writeLine(línea);
    escribir.close();
 )
pessageBox.show(" datos guardodos correctamente ");


    
