from kivymd.app import MDApp
from kivy.uix.widget import Widget
from kivy.lang import Builder
from kivy.uix.screenmanager import ScreenManager, Screen


class LoginScreen(Screen):
    pass


class MenuScreen(Screen):
    pass


class NovaOcorrenciaScreen(Screen):
    pass

class StatusScreen(Screen):
    pass

sm = ScreenManager()
sm.add_widget(LoginScreen(name='login'))
sm.add_widget(MenuScreen(name='menu'))
sm.add_widget(NovaOcorrenciaScreen(name='novaOcorrencia'))
sm.add_widget(StatusScreen(name='status'))


class DemoApp(MDApp):

    def build(self):
        self.theme_cls.primary_palette = "Green"
        self.theme_cls.primary_hue = "100"
        self.theme_cls.theme_style = "Dark"
        screen = Builder.load_file('screen.kv')
        return screen

    def clear(self):
        self.root.ids.user.text = ""
        self.root.ids.password.text = ""


DemoApp().run()
