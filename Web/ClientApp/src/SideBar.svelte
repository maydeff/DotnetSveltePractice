<script lang="ts">
    import { categories } from './store'
    import './app.css'
    import Icon from '@iconify/svelte'
</script>

<nav>
    <ul class="space-y-2 font-medium">
        {#each categories as c}
            <li>
                <a
                    href="#"
                    class="flex items-center p-2 text-read-white rounded-lg dark:text-white hover:bg-cinder-950 hover:border-b-2 hover:border-deep-blue-500 group"
                >
                    <Icon icon={c.iconName} width={30} />
                    <span class="ml-3">{c.name}</span>
                </a>
            </li>
        {/each}
    </ul>
</nav>
