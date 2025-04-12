import configparser
import os

CONFIG = "./config.ini"

config = configparser.ConfigParser()
config.read(CONFIG, encoding='utf-8')  # 推荐指定编码（如utf-8）
sections = config.sections()  # 输出：['database', 'paths']

# 获取具体配置值（字符串类型）
mode = config.get('normal', 'mode')
sleep = config.getint('normal', 'sleep')

command = 'shutdown -a'
# 判断是否是取消任务
if 'a' == mode:
    command = 'shutdown -a'
else:
    command = 'shutdown -f -%s -t %d' % (mode,sleep)

# print(command)
os.system(command)