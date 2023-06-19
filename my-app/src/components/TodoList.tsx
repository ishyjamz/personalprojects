import React from 'react';
import './styles.css';
import { Todo } from '../model';
import SingleTodo from './SingleTodo';

interface Props{
    todos: Array<Todo>;
    setTodos: React.Dispatch<React.SetStateAction<Array<Todo>>>;
}

const TodoList: React.FC<Props> = ({
    todos,
    setTodos}) => {
  return (
    <div className='todos'>
        {todos.map((todo: Todo) => {
            return (
                <SingleTodo 
                todo={todo} 
                key={todo.id}
                todos={todos}
                setTodos={setTodos}
                 />
            );
        })}
    </div>
  )
}

export default TodoList