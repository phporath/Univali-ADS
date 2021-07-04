import sys

import self as self
from PyQt5.uic import loadUi
from PyQt5 import QtWidgets
from PyQt5.QtWidgets import QDialog, QApplication, QTableWidgetItem
import sqlite3


class WelcomeScreen(QDialog):
    def __init__(self):
        super(WelcomeScreen, self).__init__()
        loadUi("welcomescreen.ui", self)
        self.login.clicked.connect(self.gotologin)
        self.create.clicked.connect(self.gotocreate)

    def gotologin(self):
        login = LoginScreen()
        widget.addWidget(login)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def gotocreate(self):
        create = CreateAccScreen()
        widget.addWidget(create)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class LoginScreen(QDialog):
    def __init__(self):
        super(LoginScreen, self).__init__()
        loadUi("login.ui", self)
        self.passwordfield.setEchoMode(QtWidgets.QLineEdit.Password)
        self.login.clicked.connect(self.loginfunction)
        self.cancel.clicked.connect(self.welcomefunction)

    def loginfunction(self):
        user = self.emailfield.text()
        password = self.passwordfield.text()

        if len(user) == 0 or len(password) == 0:
            self.error.setText("Por favor insira todos os campos.")

        else:
            conn = sqlite3.connect("banco_app.db")
            cur = conn.cursor()
            query_usuario = 'SELECT COUNT(1) FROM tb_Cadastro WHERE usuario =\'' + user + "\'"
            cur.execute(query_usuario)
            result_user = cur.fetchone()[0]

            if result_user > 0:
                query = 'SELECT senha FROM tb_Cadastro WHERE usuario =\'' + user + "\'"
                cur.execute(query)
                result_pass = cur.fetchone()[0]

                if result_pass == password:
                    print("Usuário conectado com sucesso.")
                    self.error.setText("Logado!")
                    menu = MenuScreen()
                    widget.addWidget(menu)
                    widget.setCurrentIndex(widget.currentIndex() + 1)

                else:
                    self.error.setText("Usuário ou senha inválida.")

            else:
                self.error.setText("Usuário ou senha inválida.")

    def welcomefunction(self):
        welcome = WelcomeScreen()
        widget.addWidget(welcome)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class CreateAccScreen(QDialog):
    def __init__(self):
        super(CreateAccScreen, self).__init__()
        loadUi("createacc.ui", self)
        self.passwordfield.setEchoMode(QtWidgets.QLineEdit.Password)
        self.confirmpasswordfield.setEchoMode(QtWidgets.QLineEdit.Password)
        self.signup.clicked.connect(self.signupfuncton)
        self.cancel.clicked.connect(self.welcomefunction)

    def signupfuncton(self):
        user = self.emailfield.text()
        password = self.passwordfield.text()
        confirmpassword = self.confirmpasswordfield.text()

        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_usuario = 'SELECT COUNT(1) FROM tb_Cadastro WHERE usuario =\'' + user + "\'"
        cur.execute(query_usuario)
        result_user = cur.fetchone()[0]

        if result_user > 0:
            self.error.setText("Usuário já existe.")

        else:
            if len(user) == 0 or len(password) == 0 or len(confirmpassword) == 0:
                self.error.setText("Por favor insira todos os campos.")

            elif password != confirmpassword:
                self.error.setText("Senhas não são iguais.")
            else:
                user_info = [user, password]
                cur.execute('INSERT INTO tb_Cadastro (usuario, senha) VALUES (?, ?)', user_info)

                conn.commit()
                conn.close()

                widget.addWidget(welcome)
                widget.setCurrentIndex(widget.currentIndex() + 1)

    def welcomefunction(self):
        welcome = WelcomeScreen()
        widget.addWidget(welcome)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class MenuScreen(QDialog):

    def __init__(self):
        super(MenuScreen, self).__init__()
        loadUi("menu.ui", self)
        self.nova_ocorrencia.clicked.connect(self.gotonovaocorrencia)
        self.status.clicked.connect(self.gotostatus)
        self.adm.clicked.connect(self.gotoadm)
        self.logout.clicked.connect(self.gotowelcome)

    def gotonovaocorrencia(self):
        novaocorrencia = NovaOcorrenciaScreen()
        widget.addWidget(novaocorrencia)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def gotostatus(self):
        status = StatusScreen()
        widget.addWidget(status)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def gotoadm(self):
        adm = AdmScreen()
        widget.addWidget(adm)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def gotowelcome(self):
        home = WelcomeScreen()
        widget.addWidget(home)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class NovaOcorrenciaScreen(QDialog):

    def __init__(self):
        super(NovaOcorrenciaScreen, self).__init__()
        loadUi("nova_ocorrencia.ui", self)
        self.bt_SV.clicked.connect(self.combo_box)
        self.bt_IP.clicked.connect(self.combo_box)
        self.apply.clicked.connect(self.register_function)
        self.back.clicked.connect(self.gotomenu)

    def combo_box(self):
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_problema = self.radio_button()
        cur.execute(query_problema)
        resultado = cur.fetchall()

        self.comboBox.clear()

        itens = []
        for item in resultado:
            itens.append(str(item).replace("('", "").replace("',)", ""))
        print(itens)
        for i in itens:
            self.comboBox.addItem(i)

    def radio_button(self):
        if self.bt_SV.isChecked():
            query_problema = 'SELECT tipoSV FROM tb_SistemaViario'
        elif self.bt_IP.isChecked():
            query_problema = 'SELECT tipoIP FROM tb_IluminacaoPublica'
        else:
            query_problema = ''
        print(query_problema)
        return str(query_problema)

    def register_function(self):
        bt_SV = self.bt_SV.text()
        bt_IP = self.bt_IP.text()
        comboBox = self.comboBox.currentText()
        end = self.endfield.toPlainText()
        obs = self.obsfield.toPlainText()

        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()

        if len(comboBox) == 0 or len(end) == 0 or len(obs) == 0:
            self.error.setText("Por favor insira todos os campos.")

        else:

            if self.bt_SV.isChecked():
                query_register = 'SELECT idSV FROM tb_SistemaViario WHERE tipoSV =\'' + comboBox + "\'"
                cur.execute(query_register)
                result_bt = int(cur.fetchone()[0])
                register_info = [result_bt, None, end, obs, 1]
                cur.execute('INSERT INTO tb_Reclamacao (idSV, idIP, endereco, observacao, idStatus) VALUES (?, ?, ?, '
                            '?, ?)', register_info)

            elif self.bt_IP.isChecked():
                query_register = 'SELECT idIP FROM tb_IluminacaoPublica WHERE tipoIP =\'' + comboBox + "\'"
                cur.execute(query_register)
                result_bt = int(cur.fetchone()[0])
                register_info = [None, result_bt, end, obs, 1]
                cur.execute('INSERT INTO tb_Reclamacao (idSV, idIP, endereco, observacao, idStatus) VALUES (?, ?, ?, '
                            '?, ?)', register_info)

            conn.commit()
            conn.close()
            widget.addWidget(menu)
            widget.setCurrentIndex(widget.currentIndex() + 1)

    def gotomenu(self):
        menu = MenuScreen()
        widget.addWidget(menu)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class StatusScreen(QDialog):

    def __init__(self):
        super(StatusScreen, self).__init__()
        loadUi("status.ui", self)
        self.bt_SV.clicked.connect(self.load_data)
        self.bt_IP.clicked.connect(self.load_data)
        self.tableWidget.setColumnWidth(0, 25)
        self.tableWidget.setColumnWidth(1, 100)
        self.tableWidget.setColumnWidth(2, 100)
        self.tableWidget.setColumnWidth(3, 100)
        self.tableWidget.setColumnWidth(4, 100)
        self.tableWidget.setHorizontalHeaderLabels(['ID', 'Problema', 'Endereço', 'Observação', 'Status'])
        self.apply_pendente.clicked.connect(self.selection_pendente)
        self.apply_analise.clicked.connect(self.selection_analise)
        self.apply_concluido.clicked.connect(self.selection_concluido)
        self.back.clicked.connect(self.gotomenu)

    def load_data(self):
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_count = self.radio_button_count()
        cur.execute(query_count)
        result_user = cur.fetchone()[0]
        self.tableWidget.setRowCount(int(result_user))

        tablerow = 0
        query_problema = self.radio_button()
        for row in cur.execute(query_problema):
            self.tableWidget.setItem(tablerow, 0, QtWidgets.QTableWidgetItem(str(row[0])))
            self.tableWidget.setItem(tablerow, 1, QtWidgets.QTableWidgetItem(row[7]))
            self.tableWidget.setItem(tablerow, 2, QtWidgets.QTableWidgetItem(row[3]))
            self.tableWidget.setItem(tablerow, 3, QtWidgets.QTableWidgetItem(row[4]))
            self.tableWidget.setItem(tablerow, 4, QtWidgets.QTableWidgetItem(row[9]))
            tablerow += 1

    def radio_button_count(self):
        if self.bt_SV.isChecked():
            query_count = 'SELECT COUNT(1) FROM tb_Reclamacao WHERE idSV is not NULL'

        elif self.bt_IP.isChecked():
            query_count = 'SELECT COUNT(1) FROM tb_Reclamacao WHERE idIP is not NULL'
        else:
            query_count = ''
        print(query_count)
        return str(query_count)

    def radio_button(self):
        if self.bt_SV.isChecked():
            query_problema = 'SELECT * FROM tb_Reclamacao INNER JOIN tb_SistemaViario ON ' \
                             'tb_Reclamacao.idSV=tb_SistemaViario.idSV INNER JOIN tb_Status ON ' \
                             'tb_Reclamacao.idStatus=tb_Status.idDominio'

        elif self.bt_IP.isChecked():
            query_problema = 'SELECT * FROM tb_Reclamacao INNER JOIN tb_IluminacaoPublica ON ' \
                             'tb_Reclamacao.idIP=tb_IluminacaoPublica.idIP INNER JOIN tb_Status ON ' \
                             'tb_Reclamacao.idStatus=tb_Status.idDominio'
        else:
            query_problema = ''
        return str(query_problema)

    def selection_pendente(self):
        idRec = self.tableWidget.item(self.tableWidget.currentRow(), 0).text()
        print(idRec)
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        sql_update_query = 'UPDATE tb_Reclamacao SET idStatus = 1 WHERE idREC =\'' + idRec + "\'"
        cur.execute(sql_update_query)
        conn.commit()
        conn.close()

    def selection_analise(self):
        idRec = self.tableWidget.item(self.tableWidget.currentRow(), 0).text()
        print(idRec)
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        sql_update_query = 'UPDATE tb_Reclamacao SET idStatus = 2 WHERE idREC =\'' + idRec + "\'"
        cur.execute(sql_update_query)
        conn.commit()
        conn.close()

    def selection_concluido(self):
        idRec = self.tableWidget.item(self.tableWidget.currentRow(), 0).text()
        print(idRec)
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        sql_update_query = 'UPDATE tb_Reclamacao SET idStatus = 3 WHERE idREC =\'' + idRec + "\'"
        cur.execute(sql_update_query)
        conn.commit()
        conn.close()

    def gotomenu(self):
        menu = MenuScreen()
        widget.addWidget(menu)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class AdmScreen(QDialog):

    def __init__(self):
        super(AdmScreen, self).__init__()
        loadUi("adm_modulo.ui", self)
        self.crud_user.clicked.connect(self.gotocruduser)
        self.crud_sv.clicked.connect(self.gotocrudsv)
        self.crud_ip.clicked.connect(self.gotocrudip)
        self.back.clicked.connect(self.gotomenu)

    def gotocruduser(self):
        cruduser = CRUD_User_Screen()
        widget.addWidget(cruduser)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def gotocrudsv(self):
        crudsv = CRUD_SV_Screen()
        widget.addWidget(crudsv)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def gotocrudip(self):
        crudip = CRUD_IP_Screen()
        widget.addWidget(crudip)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def gotomenu(self):
        menu = MenuScreen()
        widget.addWidget(menu)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class CRUD_User_Screen(QDialog):

    def __init__(self):
        super(CRUD_User_Screen, self).__init__()
        loadUi("crud_user.ui", self)
        self.load_data()
        self.tableWidget.setColumnWidth(0, 25)
        self.tableWidget.setColumnWidth(1, 100)
        self.tableWidget.setColumnWidth(2, 100)
        self.tableWidget.setHorizontalHeaderLabels(['ID', 'Usuário', 'Senha'])
        self.tableWidget.clicked.connect(self.selection)
        self.apply_add.clicked.connect(self.insert)
        self.apply_add.clicked.connect(self.gotocruduser)
        self.apply_delete.clicked.connect(self.remove)
        self.apply_delete.clicked.connect(self.gotocruduser)
        self.apply_update.clicked.connect(self.update)
        self.apply_update.clicked.connect(self.gotocruduser)
        self.back.clicked.connect(self.gotoadm)

    def load_data(self):
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_problema = 'SELECT * FROM tb_Cadastro'
        query_count = 'SELECT COUNT(1) FROM tb_Cadastro'
        cur.execute(query_count)
        result_user = cur.fetchone()[0]

        self.tableWidget.setRowCount(result_user)
        tablerow = 0
        for row in cur.execute(query_problema):
            self.tableWidget.setItem(tablerow, 0, QtWidgets.QTableWidgetItem(str(row[0])))
            self.tableWidget.setItem(tablerow, 1, QtWidgets.QTableWidgetItem(row[1]))
            self.tableWidget.setItem(tablerow, 2, QtWidgets.QTableWidgetItem(row[2]))
            tablerow += 1

    def gotoadm(self):
        adm = AdmScreen()
        widget.addWidget(adm)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def selection(self):
        idCadastro = self.tableWidget.item(self.tableWidget.currentRow(), 0).text()
        self.idfield.setText(idCadastro)
        usuario = self.tableWidget.item(self.tableWidget.currentRow(), 1).text()
        self.usuariofield.setText(usuario)
        senha = self.tableWidget.item(self.tableWidget.currentRow(), 2).text()
        self.senhafield.setText(senha)

    def remove(self):
        idCadastro = self.idfield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_remove = 'DELETE FROM tb_Cadastro WHERE idCadastro=\'' + idCadastro + "\'"
        cur.execute(query_remove)
        conn.commit()
        conn.close()

    def update(self):
        idCadastro = self.idfield.text()
        usuario = self.usuariofield.text()
        senha = self.senhafield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_update = 'UPDATE tb_Cadastro SET usuario =\'' + usuario + "\', senha = \'" + senha + \
                       "\' WHERE idCadastro=\'" + idCadastro + "\'"
        cur.execute(query_update)
        conn.commit()
        conn.close()

    def insert(self):
        idCadastro = self.idfield.text()
        usuario = self.usuariofield.text()
        senha = self.senhafield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_insert = 'INSERT INTO tb_Cadastro (usuario, senha) VALUES (\'' + usuario + "\', \'" + senha + "\')"
        cur.execute(query_insert)
        conn.commit()
        conn.close()

    def gotocruduser(self):
        cruduser = CRUD_User_Screen()
        widget.addWidget(cruduser)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class CRUD_SV_Screen(QDialog):

    def __init__(self):
        super(CRUD_SV_Screen, self).__init__()
        loadUi("crud_sv.ui", self)
        self.load_data()
        self.tableWidget.setColumnWidth(0, 25)
        self.tableWidget.setColumnWidth(1, 200)
        self.tableWidget.setHorizontalHeaderLabels(['ID', 'Tipo'])
        self.tableWidget.clicked.connect(self.selection)
        self.apply_add.clicked.connect(self.insert)
        self.apply_add.clicked.connect(self.gotosv)
        self.apply_delete.clicked.connect(self.remove)
        self.apply_delete.clicked.connect(self.gotosv)
        self.apply_update.clicked.connect(self.update)
        self.apply_update.clicked.connect(self.gotosv)
        self.back.clicked.connect(self.gotoadm)

    def load_data(self):
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_problema = 'SELECT * FROM tb_SistemaViario'
        query_count = 'SELECT COUNT(1) FROM tb_SistemaViario'
        cur.execute(query_count)
        result_user = cur.fetchone()[0]

        self.tableWidget.setRowCount(result_user)
        tablerow = 0
        for row in cur.execute(query_problema):
            self.tableWidget.setItem(tablerow, 0, QtWidgets.QTableWidgetItem(str(row[0])))
            self.tableWidget.setItem(tablerow, 1, QtWidgets.QTableWidgetItem(row[1]))
            tablerow += 1

    def gotoadm(self):
        adm = AdmScreen()
        widget.addWidget(adm)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def selection(self):
        idSV = self.tableWidget.item(self.tableWidget.currentRow(), 0).text()
        self.idfield.setText(idSV)
        tipo = self.tableWidget.item(self.tableWidget.currentRow(), 1).text()
        self.tipofield.setText(tipo)


    def remove(self):
        idSV = self.idfield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_remove = 'DELETE FROM tb_SistemaViario WHERE idSV=\'' + idSV + "\'"
        cur.execute(query_remove)
        conn.commit()
        conn.close()

    def update(self):
        idSV = self.idfield.text()
        tipoSV = self.tipofield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_update = 'UPDATE tb_SistemaViario SET tipoSV =\'' + tipoSV + "\' WHERE idSV=\'" + idSV + "\'"
        cur.execute(query_update)
        conn.commit()
        conn.close()

    def insert(self):
        idSV = self.idfield.text()
        tipoSV = self.tipofield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_update = 'INSERT INTO tb_SistemaViario (tipoSV) VALUES (\'' + tipoSV + "\'"')'
        cur.execute(query_update)
        conn.commit()
        conn.close()

    def gotosv(self):
        crud_sv = CRUD_SV_Screen()
        widget.addWidget(crud_sv)
        widget.setCurrentIndex(widget.currentIndex() + 1)


class CRUD_IP_Screen(QDialog):

    def __init__(self):
        super(CRUD_IP_Screen, self).__init__()
        loadUi("crud_ip.ui", self)
        self.load_data()
        self.tableWidget.setColumnWidth(0, 25)
        self.tableWidget.setColumnWidth(1, 200)
        self.tableWidget.setHorizontalHeaderLabels(['ID', 'Tipo'])
        self.tableWidget.clicked.connect(self.selection)
        self.apply_add.clicked.connect(self.insert)
        self.apply_add.clicked.connect(self.gotoip)
        self.apply_delete.clicked.connect(self.remove)
        self.apply_delete.clicked.connect(self.gotoip)
        self.apply_update.clicked.connect(self.update)
        self.apply_update.clicked.connect(self.gotoip)
        self.back.clicked.connect(self.gotoadm)

    def load_data(self):
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_problema = 'SELECT * FROM tb_IluminacaoPublica'
        query_count = 'SELECT COUNT(1) FROM tb_IluminacaoPublica'
        cur.execute(query_count)
        result_user = cur.fetchone()[0]

        self.tableWidget.setRowCount(result_user)
        tablerow = 0
        for row in cur.execute(query_problema):
            self.tableWidget.setItem(tablerow, 0, QtWidgets.QTableWidgetItem(str(row[0])))
            self.tableWidget.setItem(tablerow, 1, QtWidgets.QTableWidgetItem(row[1]))
            tablerow += 1

    def gotoadm(self):
        adm = AdmScreen()
        widget.addWidget(adm)
        widget.setCurrentIndex(widget.currentIndex() + 1)

    def selection(self):
        idIP = self.tableWidget.item(self.tableWidget.currentRow(), 0).text()
        self.idfield.setText(idIP)
        tipo = self.tableWidget.item(self.tableWidget.currentRow(), 1).text()
        self.tipofield.setText(tipo)

    def remove(self):
        idIP = self.idfield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_remove = 'DELETE FROM tb_IluminacaoPublica WHERE idIP=\'' + idIP + "\'"
        cur.execute(query_remove)
        conn.commit()
        conn.close()

    def update(self):
        idIP = self.idfield.text()
        tipo = self.tipofield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_update = 'UPDATE tb_IluminacaoPublica SET tipoIP =\'' + tipo + "\' WHERE idIP=\'" + idIP + "\'"
        cur.execute(query_update)
        conn.commit()
        conn.close()

    def insert(self):
        idIP = self.idfield.text()
        tipo = self.tipofield.text()
        conn = sqlite3.connect("banco_app.db")
        cur = conn.cursor()
        query_update = 'INSERT INTO tb_IluminacaoPublica (tipoIP) VALUES (\'' + tipo + "\'"')'
        cur.execute(query_update)
        conn.commit()
        conn.close()

    def gotoip(self):
        crud_ip = CRUD_IP_Screen()
        widget.addWidget(crud_ip)
        widget.setCurrentIndex(widget.currentIndex() + 1)

# main
app = QApplication(sys.argv)
welcome = WelcomeScreen()
menu = MenuScreen()
widget = QtWidgets.QStackedWidget()
widget.addWidget(welcome)
widget.setFixedHeight(640)
widget.setFixedWidth(480)
widget.show()

try:
    sys.exit(app.exec_())
except:
    print("Exiting")





