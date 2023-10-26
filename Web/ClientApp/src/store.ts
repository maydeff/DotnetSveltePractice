export type Category = {
    id?: number,
    name: string,
    iconName: string,
}

export const categories: Category[] = [
    {
        id: 1,
        name: 'Gaming',
        iconName: 'mdi:nintendo-game-boy',
    },
    {
        id: 2,
        name: 'Science',
        iconName: 'mdi-atom',
    },
    {
        id: 3,
        name: 'Health',
        iconName: 'ic:outline-health-and-safety',
    },
]