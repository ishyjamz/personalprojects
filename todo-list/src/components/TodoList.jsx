import { TodoItem } from "./TodoItem";

/* eslint-disable react/prop-types */
export function TodoList({ toggleTodo, deleteTodo, todos }) {
    return (

        <ul className='list'>
            {todos.length === 0 && 'No Items'}
            {todos.map(todo => {
                return (
                    <TodoItem
                        {...todo}
                        key={todo.id}
                        toggleTodo={toggleTodo}
                        deleteTodo={deleteTodo} />
                )
            })}
        </ul>
    )
}