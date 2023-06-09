-- MySQL Script generated by MySQL Workbench
-- Fri Jan 27 11:05:51 2023
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `mydb` ;

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`sondages`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`sondages` ;

CREATE TABLE IF NOT EXISTS `mydb`.`sondages` (
  `idsondages` INT NOT NULL AUTO_INCREMENT,
  `question` VARCHAR(45) NOT NULL,
  `option1` VARCHAR(45) NOT NULL,
  `option2` VARCHAR(45) NOT NULL,
  `dateDebut` DATETIME NOT NULL,
  `dateFin` DATETIME NOT NULL,
  `imgopt1` VARCHAR(45) NOT NULL,
  `imgopt2` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idsondages`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`votants`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`votants` ;

CREATE TABLE IF NOT EXISTS `mydb`.`votants` (
  `idvotants` INT NOT NULL AUTO_INCREMENT,
  `codePassRegion` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idvotants`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`sondages_has_votants`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`sondages_has_votants` ;

CREATE TABLE IF NOT EXISTS `mydb`.`sondages_has_votants` (
  `sondages_idsondages` INT NOT NULL,
  `votants_idvotants` INT NOT NULL,
  `optionChoisie` INT NOT NULL,
  `heureDeVote` DATETIME NOT NULL,
  PRIMARY KEY (`sondages_idsondages`, `votants_idvotants`),
  INDEX `fk_sondages_has_votants_votants1_idx` (`votants_idvotants` ASC) ,
  INDEX `fk_sondages_has_votants_sondages_idx` (`sondages_idsondages` ASC) ,
  CONSTRAINT `fk_sondages_has_votants_sondages`
    FOREIGN KEY (`sondages_idsondages`)
    REFERENCES `mydb`.`sondages` (`idsondages`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_sondages_has_votants_votants1`
    FOREIGN KEY (`votants_idvotants`)
    REFERENCES `mydb`.`votants` (`idvotants`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
