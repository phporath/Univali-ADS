INTERFACE PAÍS.PHP

<?php

interface Pais {

      public function idiomaPais();     

} 

?>



CLASSE ALEMANHA.PHP

<?php

require_once "Pais.php";



class Alemanha implements Pais {

      public function idiomaPais() {

            return "alemão";

      }

} 

?>



CLASSE JAPAO.PHP

<?php

require_once "Pais.php";



class Japao implements Pais {

      public function idiomaPais() {

            return "japonês";

      }

} 

?>



CLASSE FACTORY.PHP

<?php

class Factory {

    public function identificaIdioma($pais){

        switch($pais){

            case 'Alemanha':

                return new Alemanha();

                break;

            case 'Japao':

                return new Japao();

                break;

        }

    }      

} 

?>



ARQUIVO PRINCIPAL = INDEX.PHP

<?php

require_once "Pais.php";

require_once "Alemanha.php";

require_once "Japao.php";

require_once "Factory.php";



$pais = factory::identificaIdioma('Alemanha');

echo "O idioma desse país é " . $pais->idiomaPais() . " <br />";



$pais = factory::identificaIdioma('Japao');

echo "E o idioma desse outro país é " . $pais->idiomaPais() . " <br />";

?>