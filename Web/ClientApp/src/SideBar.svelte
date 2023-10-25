<script lang="ts">
    import { categories } from './store'
    import './app.css'
    import Icon from '@iconify/svelte'
</script>

<!-- h-screen bg-gray-900 text-white w-64 fixed top-0 left-0 pt-16 -->

<nav
    class="fixed bg-gray-900 text-white top-0 left-0 z-10 w-64 pt-20 h-screen transition-transform"
>
    <ul class="space-y-2 font-medium">
        {#each categories as c}
            <li>
                <a
                    href="#"
                    class="flex items-center p-2 text-gray-400 rounded-lg dark:text-white hover:bg-gray-800 dark:hover:bg-gray-700 group"
                >
                    <Icon icon={c.iconName} width={30} />
                    <span class="ml-3">{c.name}</span>
                </a>
            </li>
        {/each}
    </ul>
</nav>
