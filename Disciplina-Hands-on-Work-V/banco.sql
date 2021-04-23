CREATE SCHEMA IF NOT EXISTS `bd_Reclamacao` DEFAULT CHARACTER SET utf8 ;
USE `bd_Reclamacao` ;

CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_SistemaViario` (
  `idSV` INT NOT NULL AUTO_INCREMENT,
  `tipoSV` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`idSV`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_IluminacaoPublica` (
  `idIP` INT NOT NULL AUTO_INCREMENT,
  `tipoIP` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`idIP`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_Reclamacao` (
  `idRec` INT NOT NULL AUTO_INCREMENT,
  `idSV` INT NOT NULL,
  `idIP` INT NOT NULL,
  `observacao` VARCHAR(250) NOT NULL,
  `foto` BLOB NOT NULL,
  `coordenada` GEOMETRY NOT NULL,
  PRIMARY KEY (`idRec`),
  INDEX `idSV_idx` (`idSV` ASC) VISIBLE,
  INDEX `FK2_idx` (`idIP` ASC) VISIBLE,
  CONSTRAINT `FK1`
    FOREIGN KEY (`idSV`)
    REFERENCES `bd_Reclamacao`.`tb_SistemaViario` (`idSV`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK2`
    FOREIGN KEY (`idIP`)
    REFERENCES `bd_Reclamacao`.`tb_IluminacaoPublica` (`idIP`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_StatusDominio` (
  `idDominio` INT NOT NULL AUTO_INCREMENT,
  `idStatus` INT NOT NULL,
  `situacao` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`idDominio`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_Status` (
  `idStatus` INT NOT NULL AUTO_INCREMENT,
  `idRec` INT NOT NULL,
  `idDominio` INT NOT NULL,
  `dataStatus` DATETIME NOT NULL,
  PRIMARY KEY (`idStatus`),
  INDEX `FK_idx` (`idRec` ASC) VISIBLE,
  INDEX `FK2_idx` (`idDominio` ASC) VISIBLE,
  CONSTRAINT `FK1`
    FOREIGN KEY (`idRec`)
    REFERENCES `bd_Reclamacao`.`tb_Reclamacao` (`idRec`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK2`
    FOREIGN KEY (`idDominio`)
    REFERENCES `bd_Reclamacao`.`tb_StatusDominio` (`idDominio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
