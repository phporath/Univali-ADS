-- MySQL Script generated by MySQL Workbench
-- Wed Mar 24 22:42:26 2021
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema bd_Reclamacao
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bd_Reclamacao
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bd_Reclamacao` DEFAULT CHARACTER SET utf8 ;
USE `bd_Reclamacao` ;

-- -----------------------------------------------------
-- Table `bd_Reclamacao`.`tb_SistemaViario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_SistemaViario` (
  `idSV` INT NOT NULL AUTO_INCREMENT,
  `tipoSV` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`idSV`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bd_Reclamacao`.`tb_IluminacaoPublica`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_IluminacaoPublica` (
  `idIP` INT NOT NULL AUTO_INCREMENT,
  `tipoIP` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`idIP`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bd_Reclamacao`.`tb_Reclamacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_Reclamacao` (
  `idRec` INT NOT NULL AUTO_INCREMENT,
  `idSV` INT NOT NULL,
  `idIP` INT NOT NULL,
  `observacao` VARCHAR(250) NOT NULL,
  `foto` BLOB NOT NULL,
  `coordenada` GEOMETRY NOT NULL,
  PRIMARY KEY (`idRec`),
  INDEX `idSV_idx` (`idSV` ASC) VISIBLE,
  INDEX `idIP_idx` (`idIP` ASC) VISIBLE,
  CONSTRAINT `fk_Reclamacao_SistemaViario`
    FOREIGN KEY (`idSV`)
    REFERENCES `bd_Reclamacao`.`tb_SistemaViario` (`idSV`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Reclamacao_IluminacaoPublica`
    FOREIGN KEY (`idIP`)
    REFERENCES `bd_Reclamacao`.`tb_IluminacaoPublica` (`idIP`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bd_Reclamacao`.`tb_StatusDominio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_StatusDominio` (
  `idDominio` INT NOT NULL AUTO_INCREMENT,
  `situacao` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`idDominio`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bd_Reclamacao`.`tb_Status`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_Reclamacao`.`tb_Status` (
  `idStatus` INT NOT NULL AUTO_INCREMENT,
  `idRec` INT NOT NULL,
  `idDominio` INT NOT NULL,
  `dataStatus` DATETIME NOT NULL,
  PRIMARY KEY (`idStatus`),
  INDEX `idRec_idx` (`idRec` ASC) VISIBLE,
  INDEX `idDominio_idx` (`idDominio` ASC) VISIBLE,
  CONSTRAINT `fk_Status_Reclamacao`
    FOREIGN KEY (`idRec`)
    REFERENCES `bd_Reclamacao`.`tb_Reclamacao` (`idRec`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Status_StatusDominio`
    FOREIGN KEY (`idDominio`)
    REFERENCES `bd_Reclamacao`.`tb_StatusDominio` (`idDominio`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
