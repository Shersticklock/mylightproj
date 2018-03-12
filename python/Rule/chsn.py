                                            # Задача Child-Snack
from pyke import knowledge_engine

def main():
    my_engine = knowledge_engine.engine('bases');
    my_engine.activate('chsn_r');
    
    start = 'Robot0'; # Здесь задаётся начальная ситуация (описание возможных смотрите в файле chsn_f)
    
    my_engine.assert_('chsn_f', start, (True,));   
    
    if (start == 'Robot3'):
        final = True;
    else:
        final = False;
    
    if (start == 'Robot2'):
        osn = [1,1,1,1]; # Здесь задаётся вектор основ (для данных ситуаций все основы заполнены), 
                             # по желанию можно увеличить размер вектора (в зависимости от того сколько имеется основ)
    else:
        osn = [0,0,0,0]; # Здесь задаётся вектор основ для остальных ситуаций (0 - если основа пуста, 1 - если заполнена)
                             # по желанию можно увеличить размер вектора (в зависимости от того сколько основ)
    
    if not final:
        nOsn= len(osn);
        
        for i in range(nOsn):
            if (osn[i] == 0):
                if (start == 'Robot0'):
                    my_engine.prove_1_goal('chsn_r.robot_grasp_ingr()')[1](i);
                    osn[i] = 1;
                else:
                    my_engine.assert_('chsn_f', 'Robot0', (True,));
                    my_engine.prove_1_goal('chsn_r.robot_grasp_ingr()')[1](i);
                    osn[i] = 1;
                print('\n');
        
        for i in range(nOsn):
                    my_engine.prove_1_goal('chsn_r.robot_dispense()')[1](i); 
                print('\n');
        for i in range(nOsn):
                    my_engine.prove_1_goal('chsn_r.robot_pour()')[1](i); 
                print('\n');
                      
        my_engine.assert_('chsn_f', 'Robot3', (True,));
        my_engine.prove_1_goal('chsn_r.final()')[1]();
    else:
        my_engine.prove_1_goal('chsn_r.final()')[1]();
        
        
if (__name__ == "__main__"):
    main()