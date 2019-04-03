import pymorphy2


def pos(word, morth=pymorphy2.MorphAnalyzer()):
    """ Возвращает вероятную часть речи для *word*."""
    return morth.parse(word)[0].tag.POS

def count(words_list):
    """ Находит кол-во слов в списке для каждого слова, сортирует по количеству в порядке убывания"""
    words_set = set(words_list)
    words_dict = {}
    for word in words_set:
        words_dict[word] = words_list.count(word)
    list_tuples = list(words_dict.items())
    list_tuples.sort(key=lambda i: i[1], reverse=True)
    return list_tuples

def split_file(file):
    """ Разбивает текст на слова, исключая знаки препинания"""
    f = open(file, 'r', encoding='utf-8')
    words_list = f.read().replace('.', ' ').replace(':', ' ') \
        .replace('!', ' ').replace('\n', ' ') \
        .replace('?', ' ') \
        .replace(';', ' ').replace('"', ' ') \
        .replace('(', ' ').replace(')', ' ') \
        .replace(',', ' ').lower().split(' ')
    f.close()
    return words_list

def non_overlapping_words(list_1,list_2):
    set_1 = set(list_1)
    set_2 = set(list_2)
    symm_diff = set_1.symmetric_difference(set_2)
    return symm_diff
def word_counter(file_1,file_2):
    functors_pos = {'INTJ', 'PRCL', 'CONJ', 'PREP'}  # function words
    words_list = []
    words_list_1 = split_file(file_1)
    words_list_2 = split_file(file_2)
    words_list.extend(words_list_1)
    words_list.extend(words_list_2)
    for word in words_list:
        if word == '':
            words_list.remove(word)
    words_list = [word for word in words_list if pos(word) not in functors_pos]
    list_tuples = count(words_list)
    list_tuples = list_tuples[:20]
    #print(list_tuples)
    print("Задание № 1. Топ 20 слов")
    for i in list_tuples:
        print(i[0])
    print("Задание № 2. Cлова, которые не пересекаются в 2х текстовых файлах")
    non_ov_words = non_overlapping_words(words_list_1,words_list_2)
    print(non_ov_words)

word_counter('text_1.txt', 'text_2.txt')

